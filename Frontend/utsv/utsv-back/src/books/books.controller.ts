import { Body, Controller, Get, Param, Post, UseGuards } from '@nestjs/common';
import { AuthGuard } from '@nestjs/passport';
import { BooksService } from './books.service';
import { BookDto, ReservaDto } from './dto';
@UseGuards(AuthGuard('jwt'))
@Controller('books')
export class BooksController {
  constructor(private booksService: BooksService) {}
  @Post()
  BuscaPorlibro(@Body() dto: BookDto) {
    return this.booksService.BuscaPorlibro(dto);
  }
  @Get('/type/:type')
  type(@Param('type') type: string) {
    return this.booksService.findBytype(type);
  }

  @Post('reserva')
  reserva(@Body() dto: ReservaDto) {
    return this.booksService.PostReserva(dto);
  }
  @Get('reserva')
  Reserva() {
    return this.booksService.GetReserva();
  }
}
