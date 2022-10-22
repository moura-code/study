import { ForbiddenException, Injectable } from '@nestjs/common';
import {
  NotFoundError,
  PrismaClientKnownRequestError,
} from '@prisma/client/runtime';

import { PrismaService } from 'src/prisma/prisma.service';
import { BookDto, ReservaDto } from './dto';

@Injectable()
export class BooksService {
  constructor(private prisma: PrismaService) {}
  async BuscaPorlibro(dto: BookDto) {
    if (dto.autor) {
      try {
        const book = await this.prisma.book.findFirstOrThrow({
          where: {
            titulo: dto.titulo,
            autor: dto.autor,
          },
        });
        return book;
      } catch (err) {
        if (err instanceof NotFoundError) {
          throw new ForbiddenException('Ningun libro encontrado');
        } else {
          throw new ForbiddenException('error desconocido');
        }
      }
    } else {
      try {
        const book = await this.prisma.book.findFirstOrThrow({
          where: {
            titulo: dto.titulo,
          },
        });
        return book;
      } catch (err) {
        if (err instanceof NotFoundError) {
          throw new ForbiddenException('ningun libro encontrado');
        } else {
          throw new ForbiddenException('error desconocido');
        }
      }
    }
  }

  async findBytype(type: string) {
    const book = await this.prisma.book.findMany({
      where: {
        type: type,
      },
    });
    return book;
  }

  async PostReserva(dto: ReservaDto) {
    try {
      const reserva = await this.prisma.reserva.create({
        data: {
          nombre: dto.nombre,
          codigo_libro: dto.codigo_libro,
          carrera: dto.carrera,
          modalidad: dto.modalidad,
          matricula: dto.matricula,
        },
      });

      return reserva;
    } catch (err) {
      if (err instanceof PrismaClientKnownRequestError) {
        if ((err.code = 'P2002P')) {
          throw new ForbiddenException('Usuario ya existente');
        }
      }
    }
  }

  async GetReserva() {
    const reservas = await this.prisma.reserva.findMany();
    return reservas;
  }
}
