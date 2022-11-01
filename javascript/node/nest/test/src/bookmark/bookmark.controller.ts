import {
  Body,
  Controller,
  Delete,
  Get,
  Param,
  ParseIntPipe,
  Patch,
  Post,
  UseGuards,
} from '@nestjs/common';
import { GetUser } from '../auth/decoretor';
import { jwtGuard } from '../auth/guard';
import { BookmarkService } from './bookmark.service';
import { CreateBookmark } from './dto/create-BookmarkDto';
import { EditBookmark } from './dto/EditBookmarkDto';

@UseGuards(jwtGuard)
@Controller('bookmarks')
export class BookmarkController {
  constructor(private authService: BookmarkService) {}

  @Get()
  getBookmarks(@GetUser('id') id: number) {
    return this.authService.getBookmarks(id);
  }
  @Post()
  createBookmark(@GetUser('id') id: number, @Body() dto: CreateBookmark) {
    return this.authService.createBookmark(id, dto);
  }
  @Get(':id')
  getBookmarkById(
    @GetUser('id') userid: number,
    @Param('id', ParseIntPipe) bookmarkId: number,
  ) {
    return this.authService.getBookmarkById(userid, bookmarkId);
  }
  @Patch(':id')
  editBookmarkByid(
    @GetUser('id') id: number,
    @Body() dto: EditBookmark,
    @Param('id', ParseIntPipe) bookmarkId: number,
  ) {
    return this.authService.editBookmarkByid(id, dto);
  }
  @Delete(':id')
  deleteBookmarkById(
    @GetUser('id') userid: number,
    @Param('id', ParseIntPipe) bookmarkId: number,
  ) {
    return this.authService.deleteBookmarkById(userid, bookmarkId);
  }
}
