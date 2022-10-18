import { useState } from "react";
import Container from "react-bootstrap/Container";
import Row from "react-bootstrap/Row";
import Col from "react-bootstrap/Col";
import style from "./style.module.css";
import { catalogo } from "../../Data/main";
import { Image } from "react-bootstrap";
import { Link } from "react-router-dom";

const Catalogo = () => {
  return (
    <Container>
      <h1 className={style.title}>Catalogo</h1>
      <Row md={2}>
        {catalogo.map((ob, key) => {
          return (
            <Col key={key}>
              <Link to={ob.title}>
                <div className={style.main}>
                  <Image src={ob.img} />
                  <h6>{ob.title}</h6>
                </div>
              </Link>
            </Col>
          );
        })}
      </Row>
    </Container>
  );
};

export default Catalogo;
