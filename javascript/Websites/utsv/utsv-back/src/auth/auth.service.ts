import { ForbiddenException, Injectable } from '@nestjs/common';
import { PrismaService } from 'src/prisma/prisma.service';
import { AuthDto } from './dto';
import * as argon from 'argon2';
import { PrismaClientKnownRequestError } from '@prisma/client/runtime';
import { JwtService } from '@nestjs/jwt';
@Injectable()
export class AuthService {
  constructor(private prismaService: PrismaService, private jwt: JwtService) {}
  async singin(dto: AuthDto) {
    try {
      const user = await this.prismaService.user.create({
        data: {
          user: dto.user,
          hash: await argon.hash(dto.password),
        },
      });
      return this.singtoken(user.id, user.user);
    } catch (err) {
      if (err instanceof PrismaClientKnownRequestError)
        if ((err.code = 'P2002P')) {
          throw new ForbiddenException('Usuario ya existente');
        }
    }
  }
  async singup(dto: AuthDto) {
    const user = await this.prismaService.user.findUnique({
      where: {
        user: dto.user,
      },
    });
    if (!user) {
      throw new ForbiddenException('informaciones incorrectas');
    }
    const match = await argon.verify(user.hash, dto.password);
    if (!match) {
      throw new ForbiddenException('informaciones incorrectas');
    }

    return this.singtoken(user.id, user.user);
  }
  async singtoken(userid: number, user: string): Promise<{ token: string }> {
    const payload = {
      sub: userid,
      user,
    };

    return {
      token: await this.jwt.signAsync(payload, {
        expiresIn: '30m',
        secret: process.env.JWT_SECRET,
      }),
    };
  }
}
