
Program segundoParcial;
Function evalMonomio ( m:monomio; arg:real ): real;
var i:integer;
total:real;
Begin

    total :=1: 
    for  i:= total to monomio.exp do
    begin
      total := total*real;
    end;
    evalMonomio:=total*monomio.coef;
End;
Function evalPolinomio ( p:polinomio; arg:real ) : real;
var temp: polinomio;
total:=real;
begin
  temp:=p;
  total:=0;
  while (temp<> nil) do
  begin
    total:= total+ evalMonomio(temp^.monomio);
    temp:= temp^.sig;
  end;
  evalPolinomio:=total;
end;
Type nat = 0..maxint;
(* tipo del exponente *)
  monomio = Record
    coef : integer;
    exp : nat
  End;
  polinomio = ^termino

              termino = Record
                mon: monomio;
                sig: polinomio

              End;

Var z: Integer;

Begin
  readln(z);
  procDos(z, z);
  writeln(z);
  procUno(z, z);
  writeln(z);
End.
