import { useState } from "react";
import Button from "react-bootstrap/esm/Button";
import style from "./style.module.css";
const Consulta = () => {
  return (
    <>
      <form className={style.form}>
        <h1>Consulta de libros:</h1>
        <div>
          <h3>NOMBRE DEL LIBRO</h3>
          <input type="text" />
        </div>
        <div>
          <h3>AUTOR (opcional)</h3>
          <input type="text" />
        </div>
        <Button type="submit" className={style.button} variant="primary">
          Buscar
        </Button>
      </form>
    </>
  );
};

export default Consulta;
