import Head from "next/head";
import Image from "next/image";
import { Inter } from "@next/font/google";

export default function Home() {
  return (
    <>
      <Image
        src={"https://github.com/moura-code.png"}
        alt="Picture of the author"
        width={500}
        height={500}
      ></Image>
    </>
  );
}
