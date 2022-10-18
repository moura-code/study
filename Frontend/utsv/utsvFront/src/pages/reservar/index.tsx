import { useState } from "react";
import Button from "react-bootstrap/esm/Button";
import style from "./style.module.css";
const Reservar = () => {
  return (
    <>
      <form className={style.form}>
        <h1>Reserva de libros:</h1>
        <div>
          <h3>NOMBRE DEL ALUMNO</h3>
          <input type="text" />
        </div>
        <div>
          <h3>MATRICULA </h3>
          <input type="text" />
        </div>
        <div>
          <h3>CARRERA </h3>
          <input type="text" />
        </div>
        <div>
          <h3>MODALIDAD</h3>
          <input type="text" />
        </div>
        <div>
          <h3>CODIGO DEL LIBRO</h3>
          <input type="text" />
        </div>
        <Button type="submit" className={style.button} variant="primary">
            Reservar
          </Button>
      </form>
    </>
  );
};

export default Reservar;
