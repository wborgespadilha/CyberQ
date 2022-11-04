CREATE TABLE clientes (
       codigo NUMBER CONSTRAINT pk_clientes PRIMARY KEY,
       nome_cliente VARCHAR2(50),
       email_cliente VARCHAR2(45)
);

CREATE SEQUENCE seq_clientes
MINVALUE 1
START WITH 1
INCREMENT BY 1;

CREATE OR REPLACE TRIGGER ai_clientes
BEFORE INSERT ON clientes
FOR EACH ROW
  BEGIN
    :new.codigo := seq_clientes.NEXTVAL;
    END;

----------------------------------------

CREATE TABLE produtos (
       codigo NUMBER CONSTRAINT pk_produto PRIMARY KEY,
       nome_produto VARCHAR2(40),
       preco_produto NUMBER,
       codigo_produto VARCHAR2(50)
);

CREATE SEQUENCE seq_produtos
MINVALUE 1
START WITH 1
INCREMENT BY 1;

CREATE OR REPLACE TRIGGER ai_produtos
BEFORE INSERT ON produtos
FOR EACH ROW
  BEGIN
    :new.codigo := seq_produtos.NEXTVAL;
    END;
    
----------------------------------------


CREATE OR REPLACE PROCEDURE cadastrar_cliente(
       nome IN VARCHAR2,
       email IN VARCHAR2
)
AS

email_valido BOOLEAN;

BEGIN
  
  verificar_email(email, email_valido);

  IF email_valido = TRUE THEN
    INSERT INTO clientes (nome_cliente,email_cliente) VALUES (nome,email);
  END IF;

  END;
  

 
-------------------------------------------

CREATE OR REPLACE PROCEDURE verificar_email(
       email IN VARCHAR2,
       valido OUT BOOLEAN
)
AS

quantidade_arrobas NUMBER;
tamanhoemail NUMBER;

BEGIN
  
  SELECT 
  LENGTH(email) - LENGTH(REPLACE(email,'@',NULL)) 
  INTO quantidade_arrobas 
  FROM dual;
  
  tamanhoemail := LENGTH(email);
  
    IF tamanhoemail < 10 OR tamanhoemail = null 
    THEN
      DBMS_OUTPUT.put_line('Email inválido (tamanho)!');
      valido := FALSE;
      
    ELSIF quantidade_arrobas != 1 
    THEN
       DBMS_OUTPUT.put_line('Email inválido (@)!');
       valido := FALSE;
       
    ELSE
      valido := TRUE;
    END IF;
  
  END; 
  
-------------------------------------------

BEGIN
  cadastrar_cliente('William','asdasdsa');
  cadastrar_cliente('William','asdasdsa@@hodams.com');
  cadastrar_cliente('William','william@gmail.com');
  END;
  
  SELECT * FROM clientes;

-------------------------------------------

CREATE OR REPLACE PROCEDURE alterar_nome_cliente (
       nome_antigo IN VARCHAR2,
       nome_novo IN VARCHAR2
) 
AS
BEGIN

  UPDATE clientes SET nome_cliente = nome_novo WHERE nome_cliente = nome_antigo;  

  END;
  
  ----

CREATE OR REPLACE PROCEDURE alterar_email_cliente (
       email_antigo IN VARCHAR2,
       email_novo IN VARCHAR2
) 
AS
BEGIN

  UPDATE clientes SET email_cliente = email_novo WHERE email_cliente = email_antigo;  

  END; 
  
  ---- 
  
CREATE OR REPLACE PROCEDURE deletar_cliente_por_email(
       email VARCHAR2
)
AS
BEGIN 
  
  DELETE clientes WHERE email_cliente = email;

  END;
  
-------------------------------------------

BEGIN
  alterar_nome_cliente('William','Wilson');
  alterar_email_cliente('william@gmail.com','wilson@gmail.com');
  END;
  
SELECT * FROM clientes;
  
BEGIN 
  deletar_cliente_por_email('wilson@gmail.com');
  END;

SELECT * FROM clientes;

-------------------------------------------

CREATE OR REPLACE PROCEDURE cadastrar_produto (
       nome VARCHAR2,
       preco NUMBER
)
AS

codigo VARCHAR2(50);

BEGIN
  
  codigo := nome;
  
  gerar_codigo(codigo);
  
  INSERT INTO produtos (nome_produto,preco_produto,codigo_produto) VALUES (nome,preco,codigo);

  END;


-------------------------------------------

CREATE OR REPLACE PROCEDURE gerar_codigo(
       codigo IN OUT VARCHAR2
)
AS

BEGIN

    codigo := DBMS_RANDOM.STRING('x',LENGTH(codigo));
    
  END;
  
-------------------------------------------
BEGIN
cadastrar_produto('Cebola em barra',50);
END;

SELECT * FROM produtos;

-------------------------------------------

CREATE OR REPLACE PROCEDURE alterar_nome_produto (
       nome_antigo IN VARCHAR2,
       nome_novo IN VARCHAR2
) 
AS
BEGIN

  UPDATE produtos SET nome_produto = nome_novo WHERE nome_produto = nome_antigo;  

  END;
  
  ----

CREATE OR REPLACE PROCEDURE alterar_preco_produto (
       nome IN VARCHAR2,
       novo_preco_produto IN VARCHAR2
) 
AS
BEGIN

  UPDATE produtos SET preco_produto = novo_preco_produto WHERE nome_produto = nome;  

  END;  

  ----
  
CREATE OR REPLACE PROCEDURE deletar_produto_por_codigo(
       codigo_inserido IN VARCHAR2
)
AS
BEGIN 
  
  DELETE FROM produtos WHERE codigo_produto = codigo_inserido;

  END;

-------------------------------------------
BEGIN
alterar_nome_produto('Cebola em barra','Leite por kg');
alterar_preco_produto('Leite por kg',27.9);
END;

SELECT * FROM produtos;

BEGIN
deletar_produto_por_codigo('1LSN1TS96PUEFIF');
END;

SELECT * FROM produtos;
