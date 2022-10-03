import { Injectable } from '@nestjs/common';
import { PrismaService } from '../prisma/prisma.service';
import { CreateBookmark } from './dto/create-BookmarkDto';
import { EditBookmark } from './dto/EditBookmarkDto';

@Injectable()
export class BookmarkService {
  constructor(private prisma: PrismaService) {}

  async getBookmarks(userid: number) {
    const bookmarks = await this.prisma.bookmark.findMany({
      where: {
        id: userid,
      },
    });
    return bookmarks;
  }

  createBookmark(userid: number, dto: CreateBookmark) {}

  getBookmarkById(userid, bookmarkId) {}

  editBookmarkByid(userid: number, dto: EditBookmark) {}

  deleteBookmarkById(userid: number, bookmarkId: number) {}
}
