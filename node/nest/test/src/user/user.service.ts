import { Injectable } from '@nestjs/common';

import { PrismaService } from '../prisma/prisma.service';
import { EditDto } from './dto';

@Injectable()
export class UserService {
  constructor(private prisma: PrismaService) {}
  async getAll() {
    const users = await this.prisma.user.findMany();
    users.forEach((user) => {
      delete user.hash;
    });

    return users;
  }
  async editUser(userId: number, dto: EditDto) {
    const user = await this.prisma.user.update({
      where: {
        id: userId,
      },
      data: {
        ...dto,
      },
    });

    delete user.hash;
    return user;
  }
}
