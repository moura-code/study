import { ForbiddenException, Injectable } from '@nestjs/common';
import { PrismaService } from '../prisma/prisma.service';
import { AuthDto } from './dto';
import * as argon from 'argon2';
import { PrismaClientKnownRequestError } from '@prisma/client/runtime';
import { JwtService } from '@nestjs/jwt';
import { ConfigService } from '@nestjs/config';
@Injectable()
export class AuthService {
  constructor(
    private prisma: PrismaService,
    private jwt: JwtService,
    private config: ConfigService,
  ) {}
  async singup(dto: AuthDto) {
    const hash = await argon.hash(dto.password);
    try {
      const user = await this.prisma.user.create({
        data: {
          email: dto.email,
          hash,
        },
      });
      return this.singtoken(user.id, user.email);
    } catch (err) {
      if (err instanceof PrismaClientKnownRequestError) {
        if (err.code == 'P2002') {
          throw new ForbiddenException('Credentials taken');
        }
      }
      throw err;
    }
  }
  async singin(dto: AuthDto) {
    try {
      const user = await this.prisma.user.findUniqueOrThrow({
        where: {
          email: dto.email,
        },
      });

      const passmatch = await argon.verify(user.hash, dto.password);
      if (!passmatch) throw new Error();

      return this.singtoken(user.id, user.email);
    } catch (err) {
      throw new ForbiddenException('invalid credentials');
    }
  }
  async singtoken(userid: number, email: string): Promise<{ token: string }> {
    const payload = {
      sub: userid,
      email: email,
    };
    const toke = await this.jwt.signAsync(payload, {
      expiresIn: '20m',
      secret: this.config.get('JWT_SECRET'),
    });
    return {
      token: toke,
    };
  }
}
