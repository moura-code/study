Function todosTienenFormatoEnLinea ( tfmt : TipoFormato; ini, fin : RangoColumna
                                    ; ln : Linea ) : boolean;



{ Retorna true solo si todos los caracteres de `ln` entre las columnas `ini` y `fin`,
  incluídos los extremos, tienen el formato `tfmt`. En otro caso retorna false.

  Precondiciones: 1 <= ini <= ln.tope
                  1 <= fin <= ln.tope }

Var i: integer;
found:boolean;
Begin
i := ini;
found:=false;
While (i <= fin) and (not found) Do
begin
  If Not ln.cars[i].fmt[tfmt] Then
  begin
    found := true;
  end; 
  i:=i+1;
end;

todosTienenFormatoEnLinea := not found;

  
End;

Procedure aplicarFormatoEnLinea ( tfmt : TipoFormato; ini, fin : RangoColumna
                                 ; Var ln : Linea );



{ Aplica el formato `tfmt` a los caracteres de `ln` entre las columnas `ini` y `fin`,
  incluídos los extremos.
  Si todos los carácteres ya tienen el tipo de formato `tfmt`, en lugar de aplicarlo
  lo quita.

  Precondiciones: 1 <= ini <= ln.tope
                  1 <= fin <= ln.tope }

Var i: integer;
  all: boolean;
Begin
  all := not todosTienenFormatoEnLinea(tfmt,ini, fin,ln);
  For i := ini To fin Do
    Begin
      ln.cars[i].fmt[tfmt] := all;
    End;
End;
Function contarCaracteresEnTexto ( txt : Texto ) : integer;
{ Retorna la cantidad de caracteres que tiene el texto `txt` }

Var p: Texto;
  counter: integer;
Begin
  counter := 0;
  p := txt;
  While p <> Nil Do
    Begin
      counter := counter+ p^.info.tope;
      p := p^.sig;
    End;
  contarCaracteresEnTexto := counter;
End;
Procedure buscarCadenaEnLineaDesde ( c : Cadena; ln : Linea; desde :
                                    RangoColumna
                                    ; Var pc : PosibleColumna );



{ Busca la primera ocurrencia de la cadena `c` en la línea `ln` a partir de la
  columna `desde`. Si la encuentra, retorna en `pc` la columna en la que incia.

  Precondiciones: 1 <= desde <= ln.tope }

Var j,i: integer;
  currentC,currentLn: char;
  found: boolean;
Begin

  found := false;
  i := desde;
  While (Not found) And (i <=ln.tope) Do
    Begin
      j := 1;
      currentLn := ln.cars[i].car;
      currentC := c.cars[j];
      While (j<=c.tope) And (currentC = currentLn)   Do
        Begin
          currentLn := ln.cars[i+j -1].car;
          currentC := c.cars[j];
          j := j+1;
        End;
      If j > c.tope Then
        Begin
          found := true;
        End
      Else
        Begin
          i := i+1;
        End;
    End;
    if found then 
    begin
pc.esColumna := true;
pc.col := i;
    end
    else

    begin   
    pc.esColumna := false;

    end;
End;



Procedure buscarCadenaEnTextoDesde ( c : Cadena; txt : Texto; desde : Posicion
                                    ; Var pp : PosiblePosicion );



{ Busca la primera ocurrencia de la cadena `c` en el texto `txt` a partir de la
  posición `desde`. Si la encuentra, retorna en `pp` la posición en la que incia.
  La búsqueda no encuentra cadenas que ocupen más de una línea.

  Precondiciones: 1 <= desde.linea <= cantidad de líneas
                  1 <= desde.columna <= tope de línea en desde.linea }

Var counter,i: integer;

  currentLn: Linea;

  pc: PosibleColumna;
  p: Texto;

Begin

  pc.esColumna := false;
  p := txt;
  counter := 1;

  For i:=2 To desde.linea Do
    Begin
      counter := counter+ 1;
      p := p^.sig;
    End;

  While (p <> Nil) And (Not pc.esColumna) Do
    Begin
      currentLn := p^.info;
      buscarCadenaEnLineaDesde(c,currentLn,desde.columna,pc);
      If pc.esColumna Then
        Begin
          pp.esPosicion := True;
          pp.p.linea := counter;
          pp.p.columna := pc.col;
        End;
        If not pc.esColumna Then
  Begin
    pp.esPosicion := false;
  End;
  desde.columna:=1;
      counter := counter+ 1;
      p := p^.sig;
    End;


End;
Procedure insertarCadenaEnLinea ( c : Cadena; columna : RangoColumna
                                 ; Var ln : linea; Var pln : PosibleLinea );



{ Inserta la cadena `c` a partir de la `columna` de `ln`, y desplaza hacia la derecha
  a los restantes caracteres de la línea. Los carácteres insertados toman el formato
  del carácter que ocupaba la posición `columna` en la línea. Si la columna es
  `ln.tope+1`, entonces queda sin formato.
  Si (c.tope + lin.tope) supera `MAXCOL`, los carácteres sobrantes se retornan (en
  orden) en la posible línea `pln`.

  Precondiciones:  1 <= columna <= ln.tope+1
                   columna <= MAXCOL
                   c.tope + columna <= MAXCOL  }


Var i,j,diffence: integer;
  firstC: Caracter;

  copyln: linea;
Begin
  diffence := 0;
  If (ln.tope+c.tope) > MAXCOL Then
    Begin
      pln.esLinea := true;
      pln.l.tope := (ln.tope+c.tope)-MAXCOL;
      diffence := ln.tope+c.tope-MAXCOL;
      For  j:= 1 To diffence Do
        Begin
          pln.l.cars[ j ] := ln.cars[MAXCOL -c.tope -diffence];
        End;
    End;
  For i := 1 To c.tope+1 Do
    Begin
      firstC := ln.cars[columna+i];
      ln.cars[i+columna-1].car := c.cars[i];
      ln.cars[i+columna-1].fmt[Neg] := firstC.fmt[Neg];
      ln.cars[i+columna-1].fmt[Ita] := firstC.fmt[Ita];
      ln.cars[i+columna-1].fmt[Sub] := firstC.fmt[Sub];
    End;
  ln.tope := ln.tope+c.tope;
  j := c.tope+columna;
  While (j <= copyln.tope+c.tope-diffence) and (j <= MAXCOL)Do
    Begin
      ln.cars[j].car := copyln.cars[j-c.tope].car;
      ln.cars[j].fmt := copyln.cars[j-c.tope].fmt;
      j := j+1;
    End;
End;


Procedure insertarLineaEnTexto ( ln : Linea; nln : integer; Var txt : Texto );



{ Inserta la línea `ln` en la posición `nlin` del texto `txt`.

  Precondiciones: 1 < nln <= cantidad de líneas del texto + 1
}

Var i:integer;
var newnodo:Texto;
var temp1,temp2:Texto;
Begin
temp1:= txt;
for i:=1 to nln-2 Do
begin  
 temp1:=temp1^.sig;
end;
new(newnodo);
newnodo^.info:=ln;
temp2 := temp1^.sig;
temp1^.sig := newnodo;
newnodo^.sig := temp2;
End;
