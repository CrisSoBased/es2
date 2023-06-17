CREATE TABLE perfil (
    id_perfil integer NOT NULL,
    nome character varying NOT NULL,
    pais character varying NOT NULL,
    mail character varying NOT NULL,
    preco_hora numeric NOT NULL,
    visibilidade character varying NOT NULL,
    id_user integer NOT NULL
);

CREATE TABLE skill (
    id_skill integer NOT NULL,
    nome character varying NOT NULL,
    area_profissional character varying NOT NULL
);

CREATE TABLE skill_profissional (
    id_perfil integer NOT NULL,
    id_skill integer NOT NULL
    
);

CREATE TABLE users (
    id_user integer NOT NULL,
    username character varying NOT NULL,
    password character varying NOT NULL
);

CREATE TABLE detalhe (
    id_detalhe integer NOT NULL,
    titulo character varying NOT NULL,
    empresa character varying NOT NULL,
    ano_inicio character varying NOT NULL,
    ano_fim character varying NOT NULL,
     id_skill integer NOT NULL,
     id_perfil integer NOT NULL
);

