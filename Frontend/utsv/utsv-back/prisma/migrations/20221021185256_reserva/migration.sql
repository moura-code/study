-- CreateTable
CREATE TABLE "Reserva" (
    "id" SERIAL NOT NULL,
    "nombre" TEXT NOT NULL,
    "matricula" INTEGER NOT NULL,
    "carrera" TEXT NOT NULL,
    "modalidad" TEXT NOT NULL,
    "codigo_libro" INTEGER NOT NULL,

    CONSTRAINT "Reserva_pkey" PRIMARY KEY ("id")
);
