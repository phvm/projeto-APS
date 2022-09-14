--Inserir Profissional de Saude
INSERT INTO Contas(CPF, Senha, Nome, Email, IsAdministrador, IsProfissionalDeSaude, IsCidadao)
VALUES ('111.111.111-11', '12345', 'Matheus Correia', 'mcr@cin.ufpe.br', 0, 1, 0);

--Inserir Cidadao
INSERT INTO Contas(CPF, Senha, Nome, Email, IsAdministrador, IsProfissionalDeSaude, IsCidadao)
VALUES ('222.222.222-22', '12345', 'Matheus Lucena', 'matheusepitacio@gmail.com', 0, 0, 1),
('333.333.333-33', '12345', 'Pedro Henrique', 'phvm@cin.ufpe.br', 0, 0, d1);