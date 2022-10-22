import { IsNotEmpty, IsNumber, IsOptional, IsString } from 'class-validator';
export class BookDto {
  @IsNotEmpty()
  @IsString()
  titulo: string;
  @IsString()
  @IsOptional()
  autor: string;
}

export class ReservaDto {
  @IsString()
  nombre: string;
  @IsString()
  matricula: string;
  @IsString()
  carrera: string;
  @IsString()
  modalidad: string;
  @IsString()
  codigo_libro: string;
}
