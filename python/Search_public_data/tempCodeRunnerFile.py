tk.Button(self, text='Empresas',height= 3, width=10, command=lambda: self.comecar(Empresas()),font=tkFont.Font(family='Helvetica', size=10, weight='bold')).place(x=70, y=330)
        tk.Button(self, text='Socios',height= 3, width=10, command=lambda:self.comecar(Socios()),font=tkFont.Font(family='Helvetica', size=10, weight='bold')).place(x=350, y=330)
        tk.Button(self, text='Estabelecimentos',height= 4, width=14, command=lambda:self.comecar(Establecimentos()),font=tkFont.Font(family='Helvetica', size=8, weight='bold')).place(x=200, y=325) 