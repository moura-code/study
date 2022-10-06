import { Controller, Get, Patch, UseGuards, Body } from '@nestjs/common';
import { User } from '@prisma/client';

import { GetUser } from '../auth/decoretor';
import { jwtGuard } from '../auth/guard';
import { EditDto } from './dto';
import { UserService } from './user.service';

@UseGuards(jwtGuard)
@Controller('users')
export class UserController {
  constructor(private userService: UserService) {}
  @Get('me')
  getMe(@GetUser() user: User) {
    return user;
  }
  @Get()
  getAll() {
    return this.userService.getAll();
  }
  @Patch()
  editUser(@GetUser('id') userId: number, @Body() dto: EditDto) {
    return this.userService.editUser(userId, dto);
  }
}
