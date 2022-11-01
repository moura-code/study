import axios from "axios";
import { useEffect, useState } from "react";
import Button from "react-bootstrap/esm/Button";
import { Link, useNavigate } from "react-router-dom";
import style from "./style.module.css";
const Reservar = ({ loged }: { loged: boolean }) => {
  const [nombre, setn] = useState("");
  const [matricula, setm] = useState("");
  const [carrera, setc] = useState("");
  const [modalidad, setmo] = useState("");
  const [codigo, setco] = useState("");

  let navigate = useNavigate();
  useEffect(() => {
    if (!loged) {
      navigate("/");
    }
  }, [loged]);

  const fetchlogin = async () => {
    try {
      

      const data = await axios.post(
        "http://localhost:3000/books/reserva",
        {
          nombre: nombre,
          codigo_libro: codigo,
          carrera: carrera,
          modalidad: modalidad,
          matricula: matricula,
        },
        {
          headers: {
            Authorization: "Bearer " + localStorage.getItem("token"),
          },
        }
      );
    } catch (err: any) {}
  };
  return (
    <>
      <div className={style.form}>
        <h1>Reserva de libros:</h1>
        <div>
          <h3>NOMBRE DEL ALUMNO</h3>
          <input
            type="text"
            autoComplete="nombre"
            value={nombre}
            onChange={(e) => setn(e.target.value)}
          />
        </div>
        <div>
          <h3>MATRICULA </h3>
          <input
            type="text"
            autoComplete="matricula"
            value={matricula}
            onChange={(e) => setm(e.target.value)}
          />
        </div>
        <div>
          <h3>CARRERA </h3>
          <input
            type="text"
            autoComplete="carrera"
            value={carrera}
            onChange={(e) => setc(e.target.value)}
          />
        </div>
        <div>
          <h3>MODALIDAD</h3>
          <input
            type="text"
            autoComplete="modalidad"
            value={modalidad}
            onChange={(e) => setmo(e.target.value)}
          />
        </div>
        <div>
          <h3>CODIGO DEL LIBRO</h3>
          <input
            type="text"
            autoComplete="codigo"
            value={codigo}
            onChange={(e) => setco(e.target.value)}
          />
        </div>
        <Button
          type="submit"
          className={style.button}
          variant="primary"
          onClick={fetchlogin}
        >
          Reservar
        </Button>
        <Link to="all">
          <Button
            type="submit"
            className={style.button}
            variant="secundary"
            disabled={
              !codigo || !nombre || !matricula || !modalidad || !carrera
            }
          >
            Ver reservas
          </Button>
        </Link>
      </div>
    </>
  );
};

export default Reservar;
