import { INestApplication, ValidationPipe } from '@nestjs/common';
import { Test } from '@nestjs/testing';
import { PrismaService } from '../src/prisma/prisma.service';
import * as pactum from 'pactum';
import { AppModule } from '../src/app.module';
import { AuthDto } from '../src/auth/dto';
import { EditDto } from '../src/user/dto';
import { CreateBookmark } from 'src/bookmark/dto/create-BookmarkDto';
describe('AppController (e2e)', () => {
  let app: INestApplication;
  let prisma: PrismaService;
  beforeAll(async () => {
    const moduleRef = await Test.createTestingModule({
      imports: [AppModule],
    }).compile();
    app = moduleRef.createNestApplication();
    app.useGlobalPipes(new ValidationPipe({ whitelist: true }));
    await app.init();
    await app.listen(3333);
    prisma = app.get(PrismaService);
    await prisma.cleanDB();
    pactum.request.setBaseUrl('http://localhost:3333');
  });
  afterAll(() => {
    app.close();
  });
  describe('Auth', () => {
    const dto: AuthDto = {
      email: 'test@gmail.com',
      password: 'test',
    };
    describe('Singup', () => {
      const dto: AuthDto = {
        email: 'test@gmail.com',
        password: 'test',
      };
      it('should throw a error that email should not be empty', () => {
        return pactum
          .spec()
          .post('/auth/singup')
          .withBody({
            password: dto.password,
          })
          .expectStatus(400);
      });
      it('should throw a error that password should not be empty', () => {
        return pactum
          .spec()
          .post('/auth/singup')
          .withBody({
            email: dto.email,
          })
          .expectStatus(400);
      });
      it('should singup', () => {
        return pactum
          .spec()
          .post('/auth/singup')
          .withBody(dto)
          .expectStatus(201);
      });
    });
    describe('Singin', () => {
      it('should throw a error that email should not be empty', () => {
        return pactum
          .spec()
          .post('/auth/singup')
          .withBody({
            password: dto.password,
          })
          .expectStatus(400);
      });
      it('should throw a error that password should not be empty', () => {
        return pactum
          .spec()
          .post('/auth/singup')
          .withBody({
            email: dto.email,
          })
          .expectStatus(400);
      });
      it('should singin', () => {
        return pactum
          .spec()
          .post('/auth/singin')
          .withBody(dto)
          .expectStatus(200)
          .stores('userAt', 'token');
      });
    });
  });
  describe('User', () => {
    describe('Get me', () => {
      it('should return error 401 because it not have Authorization ', () => {
        return pactum.spec().get('/users/me').expectStatus(401);
      });
      it('should return current user', () => {
        return pactum
          .spec()
          .get('/users/me')
          .withHeaders({
            Authorization: 'Bearer $S{userAt}',
          })
          .expectStatus(200);
      });
    });
    describe('Edit user', () => {
      it('should edit user', () => {
        const dto: EditDto = {
          firstName: 'Vladimir',
          email: 'vlad@codewithvlad.com',
        };
        return pactum
          .spec()
          .patch('/users')
          .withHeaders({
            Authorization: 'Bearer $S{userAt}',
          })
          .withBody(dto)
          .expectStatus(200)
          .expectBodyContains(dto.firstName)
          .expectBodyContains(dto.email);
      });
    });
    describe('Get all users', () => {
      it('should return all users', () => {
        return pactum
          .spec()
          .get('/users')
          .withHeaders({
            Authorization: 'Bearer $S{userAt}',
          })
          .expectStatus(200)
          .expectJsonLength(1);
      });
    });
  });
  describe('Bookmarks', () => {
    const dto: CreateBookmark = {
      title: 'test title',
      descrption: 'test descrption',
      link: 'http test link',
    };
    describe('Create Bookmark', () => {
      it('it shloud create a book mark', () => {
        return pactum
          .spec()
          .post('/bookmarks')
          .withHeaders({
            Authorization: 'Bearer $S{userAt}',
          })
          .withBody(dto)
          .expectStatus(201)
          .stores('bookmarkId', 'id');
      });
    });
    describe('Get books marks', () => {
      it('should get book marks', () => {
        return pactum
          .spec()
          .get('/bookmarks')
          .withHeaders({
            Authorization: 'Bearer $S{userAt}',
          })
          .expectStatus(200)
          .expectBody([]);
      });
    });
    describe('Get book mark by id', () => {
      it('should get book marks by user id', () => {
        return pactum
          .spec()
          .get('/bookmarks/{id}')
          .withPathParams('id', '$S{bookmarkId}')
          .withHeaders({
            Authorization: 'Bearer $S{userAt}',
          })
          .expectStatus(200)
          .inspect();
      });
    });
    describe('Edit book mark by id', () => {});
    describe('delete book mark by id', () => {});
  });
});
