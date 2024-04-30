USE PROYECTOODS
GO

DELETE FROM INICIATIVA_METAS
DELETE FROM METAS
DELETE FROM ODS
GO

--INSERTAR DATOS EN ODS
INSERT INTO ODS VALUES ( 1,'Fin de la pobreza', 'Acabar con la pobreza en todas sus formas en todo el mundo');
INSERT INTO ODS VALUES (2, 'Hambre cero', 'Poner fin al hambre, lograr la seguridad alimentaria y la mejora de la nutrición y promover la agricultura sostenible');
INSERT INTO ODS VALUES (3, 'Salud y bienestar', 'Garantizar una vida sana y promover el bienestar para todos en todas las edades');
INSERT INTO ODS VALUES (4, 'Educación de calidad', 'Garantizar una educación inclusiva, equitativa y de calidad, y promover oportunidades de aprendizaje durante toda la vida para todos');
INSERT INTO ODS VALUES (5, 'Igualdad de género', 'Lograr la igualdad de género y empoderar a todas las mujeres y niñas');
INSERT INTO ODS VALUES (6, 'Agua limpia y saneamiento', 'Garantizar la disponibilidad de agua y su gestión sostenible y el saneamiento para todos');
INSERT INTO ODS VALUES (7, 'Energía asequible y no contaminante', 'Garantizar el acceso a una energía asequible, segura, sostenible y moderna para todos');
INSERT INTO ODS VALUES (8, 'Trabajo decente y crecimiento económico', 'Promover el crecimiento económico sostenido, inclusivo y sostenible, el empleo pleno y productivo y el trabajo decente para todos');
INSERT INTO ODS VALUES (9, 'Industria, innovación e infraestructura', 'Construir infraestructuras resilientes, promover la industrialización inclusiva y sostenible y fomentar la innovación');
INSERT INTO ODS VALUES (10, 'Reducción de las desigualdades', 'Reducir la desigualdad en y entre los países');
INSERT INTO ODS VALUES (11, 'Ciudades y comunidades sostenibles', 'Lograr que las ciudades y los asentamientos humanos sean inclusivos, seguros, resilientes y sostenibles');
INSERT INTO ODS VALUES (12, 'Producción y consumo responsables', 'Garantizar modalidades de consumo y producción sostenibles');
INSERT INTO ODS VALUES (13, 'Acción por el clima', 'Adoptar medidas urgentes para combatir el cambio climático y sus efectos');
INSERT INTO ODS VALUES (14, 'Vida submarina', 'Conservar y utilizar en forma sostenible los océanos, los mares y los recursos marinos para el desarrollo sostenible');
INSERT INTO ODS VALUES (15, 'Vida de ecosistemas terrestres', 'Proteger, restablecer y promover el uso sostenible de los ecosistemas terrestres, gestionar de manera sostenible los bosques, luchar contra la desertificación, detener e invertir la degradación de la tierra y poner freno a la pérdida de la diversidad biológica');
INSERT INTO ODS VALUES (16, 'Paz, justicia e instituciones sólidas', 'Promover sociedades pacíficas e inclusivas para el desarrollo sostenible, facilitar el acceso a la justicia para todos y construir a todos los niveles instituciones eficaces e inclusivas que rindan cuentas');
INSERT INTO ODS VALUES (17, 'Alianzas para lograr los objetivos', 'Fortalecer los medios de ejecución y revitalizar la alianza mundial para el desarrollo sostenible');


--INSERTAR DATOS EN METAS
INSERT INTO METAS VALUES (1, '1.1', 'Erradicar la pobreza extrema', 'Meta 1.1');
INSERT INTO METAS VALUES (2, '2.1', 'Acabar con el hambre', 'Meta 2.1');
INSERT INTO METAS VALUES (3, '3.1', 'Reducir la mortalidad materna', 'Meta 3.1');
INSERT INTO METAS VALUES (4, '4.1', 'Lograr la educación primaria universal', 'Meta 4.1');
INSERT INTO METAS VALUES (5, '5.1', 'Poner fin a todas las formas de discriminación contra todas las mujeres y niñas', 'Meta 5.1');

--INICIATIVA_METAS
INSERT INTO INICIATIVA_METAS VALUES (1, 1, '1.1');
INSERT INTO INICIATIVA_METAS VALUES (2, 2, '2.1');
INSERT INTO INICIATIVA_METAS VALUES (3, 3, '3.1');
INSERT INTO INICIATIVA_METAS VALUES (4, 4, '4.1');
INSERT INTO INICIATIVA_METAS VALUES (4, 5, '5.1');