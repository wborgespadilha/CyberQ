CREATE TABLE produtos(
       nome VARCHAR2(40),
       marca VARCHAR2(20),
       valor NUMBER,
       estoque NUMBER
);

INSERT INTO produtos VALUES('Teclado','Microsoft',220.00,60);
INSERT INTO produtos VALUES('Monitor 32','Samsung',3700.00,20);
INSERT INTO produtos VALUES('Mouse','Logitech',129.90,45);
INSERT INTO produtos VALUES('Impressora','Epson',430.00,15);
INSERT INTO produtos VALUES('Mouse','Microsoft',199.90,50);
INSERT INTO produtos VALUES('Monitor 27','LG',1990.80,30);
INSERT INTO produtos VALUES('Cadeira Gamer','Multilaser',1170.00,20);
INSERT INTO produtos VALUES('Teclado','Dell',110.00,50);
INSERT INTO produtos VALUES('Mouse','HP',80.00,70);
INSERT INTO produtos VALUES('Placa de vídeo - GeForce GTX 1660','ASUS',2800.00,10);
INSERT INTO produtos VALUES('SSD de 256GB','Kingston',400.00,15);
INSERT INTO produtos VALUES('Processador Core i5 - 10º geração','Intel',1800.00,10);
INSERT INTO produtos VALUES('Mouse','Multilaser',44.90,70);
INSERT INTO produtos VALUES('Monitor 23','Dell',1080.00,40);
INSERT INTO produtos VALUES('Teclado','HP',119.90,25);

-- Listar a quantidade de produtos por marca

SELECT marca, COUNT (*) FROM produtos GROUP BY marca

-- Média de todos os produtos registrados

SELECT AVG(valor) AS media FROM produtos

-- Nome da marca e soma do valor dos produtos da marca

SELECT marca, SUM(valor) AS total FROM produtos GROUP BY marca;

-- Exibir produtos em valor ?crescente

SELECT nome,valor FROM produtos ORDER BY valor DESC;

-- Nome e valor do produto mais caro

SELECT nome,valor FROM produtos WHERE valor = (SELECT MAX(valor) FROM produtos);

-- Produtos com valor maior ou igual a média de valor

SELECT * FROM produtos WHERE valor >= (SELECT AVG(valor) FROM produtos);

-- Informar produto com maior estoque

SELECT * FROM produtos WHERE estoque = (SELECT MAX(estoque) FROM produtos);

-- Produtos entre 100 e 500 reais

SELECT nome,marca,valor FROM produtos WHERE valor BETWEEN 100 and 500;

-- Nome, marca e valor dos mouses em ordem crescente de preço

SELECT nome,marca,valor FROM produtos WHERE nome LIKE 'Mouse%' ORDER BY valor ASC;

-- Nome do produto e quantidade de letras

SELECT nome, LENGTH(nome) AS letras FROM produtos;

-- Trocar DELL para Alienware

UPDATE produtos SET marca = 'Alienware' WHERE marca = 'Dell';

-- Excluir a tabela

DROP TABLE produtos;














