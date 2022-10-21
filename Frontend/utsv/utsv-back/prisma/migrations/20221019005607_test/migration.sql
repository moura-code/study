-- CreateTable
CREATE TABLE "Book" (
    "id" SERIAL NOT NULL,
    "titulo" TEXT NOT NULL,
    "editorial" TEXT NOT NULL,
    "autor" TEXT NOT NULL,

    CONSTRAINT "Book_pkey" PRIMARY KEY ("id")
);
