CREATE TABLE perfil (
                        id_perfil integer NOT NULL GENERATED ALWAYS AS IDENTITY,
                        nome character varying NOT NULL,
                        pais character varying NOT NULL,
                        mail character varying NOT NULL,
                        preco_hora numeric NOT NULL,
                        visibilidade character varying NOT NULL,
                        id_user integer NOT NULL,
                        CONSTRAINT perfil_pk PRIMARY KEY (id_perfil),
                        CONSTRAINT perfil_fk FOREIGN KEY (id_user) REFERENCES users(id_user)
);

CREATE TABLE skill (
                       id_skill integer NOT NULL GENERATED ALWAYS AS IDENTITY,
                       nome character varying NOT NULL,
                       area_profissional character varying NOT NULL,
                       CONSTRAINT skill_pk PRIMARY KEY (id_skill)
);

CREATE TABLE skill_profissional (
                                    id_perfil integer NOT NULL,
                                    id_skill integer NOT NULL,
                                    CONSTRAINT skill_profissional_pk PRIMARY KEY (id_perfil, id_skill),
                                    CONSTRAINT skill_profissional_fk FOREIGN KEY (id_skill) REFERENCES skill(id_skill),
                                    CONSTRAINT skill_profissional_fk_1 FOREIGN KEY (id_perfil) REFERENCES perfil(id_perfil)

);

CREATE TABLE users (
                       id_user integer NOT NULL GENERATED ALWAYS AS IDENTITY,
                       username character varying NOT NULL,
                       password character varying NOT NULL,
                       CONSTRAINT user_pk PRIMARY KEY (id_user)
);

CREATE TABLE detalhe (
                         id_detalhe integer NOT NULL GENERATED ALWAYS AS IDENTITY,
                         titulo character varying NOT NULL,
                         empresa character varying NOT NULL,
                         ano_inicio character varying NOT NULL,
                         ano_fim character varying NOT NULL,
                         id_skill integer NOT NULL,
                         id_perfil integer NOT NULL,
                         CONSTRAINT detalhe_pk PRIMARY KEY (id_detalhe),
                         CONSTRAINT detalhe_fk FOREIGN KEY (id_perfil,id_skill) REFERENCES skill_profissional(id_perfil,id_skill)
);