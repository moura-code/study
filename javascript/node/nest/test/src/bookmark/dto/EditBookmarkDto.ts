import { IsOptional, IsString } from 'class-validator';

export class EditBookmark {
  @IsString()
  @IsOptional()
  title?: string;
  @IsString()
  @IsOptional()
  descrption?: string;
  @IsString()
  @IsOptional()
  link?: string;
}
