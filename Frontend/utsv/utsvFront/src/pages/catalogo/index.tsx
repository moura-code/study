import { useState } from "react";
import Button from "react-bootstrap/esm/Button";
import style from "./style.module.css";
const Catalogo = () => {


  return (
    <>
      
        <form className={style.form}>
          <div>
            <h2>Usuario:</h2>
            <input type="text" />

            <h2>Passoword:</h2>
            <input type="password" />
          </div>
          <Button type="submit" className={style.button} variant="primary">
            ingresar
          </Button>
        </form>
    </>
  );
};

export default Catalogo;
