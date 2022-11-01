import axios from "axios";
import { useEffect, useState } from "react";
import { Container } from "react-bootstrap";
import Button from "react-bootstrap/esm/Button";
import { useNavigate } from "react-router-dom";
import style from "./style.module.css";
const Consulta = ({ loged }: { loged: boolean }) => {
  const [titulo, setT] = useState("");
  const [autor, setA] = useState("");
  const [libro, setlibro] = useState("");
  const [errrorMessage, setErrorMessage] = useState("");
  let navigate = useNavigate();
  useEffect(() => {
    if (!loged) {
      navigate("/");
    }
  }, [loged]);

  const fetchLibro = async () => {
    if (autor) {
      try {
        const data = await axios.post(
          "http://localhost:3000/books/",
          {
            titulo: titulo,
            autor: autor,
          },
          {
            headers: {
              Authorization: "Bearer " + localStorage.getItem("token"),
            },
          }
        );

        setlibro(data.data);
      } catch (err: any) {
        setErrorMessage(err.response.data.message);
      }
    } else {
      try {
        const data = await axios.post(
          "http://localhost:3000/books/",
          {
            titulo: titulo,
          },
          {
            headers: {
              Authorization: "Bearer " + localStorage.getItem("token"),
            },
          }
        );

        setlibro(data.data);
      } catch (err: any) {
        setErrorMessage(err.response.data.message);
      }
    }
  };
  return (
    <>
      <div className={style.form}>
        {errrorMessage ? (
          <h1 style={{ color: "red" }}>{errrorMessage}</h1>
        ) : (
          <></>
        )}
        <h1>Consulta de libros:</h1>
        <div>
          <h3>NOMBRE DEL LIBRO</h3>
          <input
            type="text"
            autoComplete="titulo"
            value={titulo}
            onChange={(e) => setT(e.target.value)}
          />
        </div>
        <div>
          <h3>AUTOR (opcional)</h3>
          <input
            type="text"
            autoComplete="titulo"
            value={autor}
            onChange={(e) => setA(e.target.value)}
          />
        </div>
        <Button
          type="submit"
          className={style.button}
          variant="primary"
          disabled={!titulo}
          onClick={fetchLibro}
        >
          Buscar
        </Button>
      </div>
      {libro ? (
        <Container className={style.libro}>
          <h2>Titulo: {libro.titulo}</h2>
          <h3>Tipo del libro:{libro.type}</h3>
          <h3>Editorial: {libro.editorial}</h3>
          <h3>Autor: {libro.autor}</h3>
        </Container>
      ) : (
        <></>
      )}
    </>
  );
};

export default Consulta;
