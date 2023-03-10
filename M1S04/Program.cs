using M1S04; 
Bebida bebida = new Bebida(1, "Diet", 1000, "Coca-Cola", (decimal)2.00);
Refrigerante refrigerante = new Refrigerante(true, 2, "Diet", 1000, "Fanta", (decimal)3.00);
Suco suco = new Suco("Grande", 3, "Integral", 1000, "Del Vale", 4);
Repositorio.InserirBebida(bebida);
Repositorio.InserirBebida(refrigerante);
Repositorio.InserirBebida(suco); 

bebida.Id= 1;
bebida.NomeBebida = "Alterado para Mountain Dew";
Repositorio.Alterar(bebida); 