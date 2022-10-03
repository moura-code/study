import { IsNotEmpty, IsOptional, IsString } from 'class-validator';

export class CreateBookmark {
  @IsString()
  @IsNotEmpty()
  title: string;
  @IsString()
  @IsOptional()
  descrption?: string;
  @IsString()
  @IsNotEmpty()
  link: string;
}
