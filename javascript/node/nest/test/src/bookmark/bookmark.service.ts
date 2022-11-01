import { ForbiddenException, Injectable } from '@nestjs/common';
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

  async createBookmark(userid: number, dto: CreateBookmark) {
    return await this.prisma.bookmark.create({
      data: { userId: userid, ...dto },
    });
  }

  async getBookmarkById(userid, bookmarkId) {
    return await this.prisma.bookmark.findFirst({
      where: { id: bookmarkId, userId: userid },
    });
  }

  async editBookmarkByid(
    userid: number,
    bookmarkId: number,
    dto: EditBookmark,
  ) {
    const bookmark = await this.prisma.bookmark.findUnique({
      where: {
        id: bookmarkId,
      },
    });
    if (!bookmark || bookmark.userId !== userid) {
      throw new ForbiddenException('Access denied');
    }
    return this.prisma.bookmark.update({
      where: {
        id: bookmarkId,
      },
      data: {
        ...dto,
      },
    });
  }

  async deleteBookmarkById(userid: number, bookmarkId: number) {}
}
