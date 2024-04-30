USE PROYECTOODS
GO

DELETE FROM INICIATIVA_METAS
DELETE FROM METAS
DELETE FROM ODS
GO

--INSERTAR DATOS EN ODS
INSERT INTO ODS VALUES ( 1,'Fin de la pobreza', 'Acabar con la pobreza en todas sus formas en todo el mundo');
INSERT INTO ODS VALUES (2, 'Hambre cero', 'Poner fin al hambre, lograr la seguridad alimentaria y la mejora de la nutrici�n y promover la agricultura sostenible');
INSERT INTO ODS VALUES (3, 'Salud y bienestar', 'Garantizar una vida sana y promover el bienestar para todos en todas las edades');
INSERT INTO ODS VALUES (4, 'Educaci�n de calidad', 'Garantizar una educaci�n inclusiva, equitativa y de calidad, y promover oportunidades de aprendizaje durante toda la vida para todos');
INSERT INTO ODS VALUES (5, 'Igualdad de g�nero', 'Lograr la igualdad de g�nero y empoderar a todas las mujeres y ni�as');
INSERT INTO ODS VALUES (6, 'Agua limpia y saneamiento', 'Garantizar la disponibilidad de agua y su gesti�n sostenible y el saneamiento para todos');
INSERT INTO ODS VALUES (7, 'Energ�a asequible y no contaminante', 'Garantizar el acceso a una energ�a asequible, segura, sostenible y moderna para todos');
INSERT INTO ODS VALUES (8, 'Trabajo decente y crecimiento econ�mico', 'Promover el crecimiento econ�mico sostenido, inclusivo y sostenible, el empleo pleno y productivo y el trabajo decente para todos');
INSERT INTO ODS VALUES (9, 'Industria, innovaci�n e infraestructura', 'Construir infraestructuras resilientes, promover la industrializaci�n inclusiva y sostenible y fomentar la innovaci�n');
INSERT INTO ODS VALUES (10, 'Reducci�n de las desigualdades', 'Reducir la desigualdad en y entre los pa�ses');
INSERT INTO ODS VALUES (11, 'Ciudades y comunidades sostenibles', 'Lograr que las ciudades y los asentamientos humanos sean inclusivos, seguros, resilientes y sostenibles');
INSERT INTO ODS VALUES (12, 'Producci�n y consumo responsables', 'Garantizar modalidades de consumo y producci�n sostenibles');
INSERT INTO ODS VALUES (13, 'Acci�n por el clima', 'Adoptar medidas urgentes para combatir el cambio clim�tico y sus efectos');
INSERT INTO ODS VALUES (14, 'Vida submarina', 'Conservar y utilizar en forma sostenible los oc�anos, los mares y los recursos marinos para el desarrollo sostenible');
INSERT INTO ODS VALUES (15, 'Vida de ecosistemas terrestres', 'Proteger, restablecer y promover el uso sostenible de los ecosistemas terrestres, gestionar de manera sostenible los bosques, luchar contra la desertificaci�n, detener e invertir la degradaci�n de la tierra y poner freno a la p�rdida de la diversidad biol�gica');
INSERT INTO ODS VALUES (16, 'Paz, justicia e instituciones s�lidas', 'Promover sociedades pac�ficas e inclusivas para el desarrollo sostenible, facilitar el acceso a la justicia para todos y construir a todos los niveles instituciones eficaces e inclusivas que rindan cuentas');
INSERT INTO ODS VALUES (17, 'Alianzas para lograr los objetivos', 'Fortalecer los medios de ejecuci�n y revitalizar la alianza mundial para el desarrollo sostenible');


--INSERTAR DATOS EN METAS
INSERT INTO METAS VALUES (1, '1.1', 'Erradicar la pobreza extrema', 'Meta 1.1');
INSERT INTO METAS VALUES (2, '2.1', 'Acabar con el hambre', 'Meta 2.1');
INSERT INTO METAS VALUES (3, '3.1', 'Reducir la mortalidad materna', 'Meta 3.1');
INSERT INTO METAS VALUES (4, '4.1', 'Lograr la educaci�n primaria universal', 'Meta 4.1');
INSERT INTO METAS VALUES (5, '5.1', 'Poner fin a todas las formas de discriminaci�n contra todas las mujeres y ni�as', 'Meta 5.1');

--INICIATIVA_METAS
INSERT INTO INICIATIVA_METAS VALUES (1, 1, '1.1');
INSERT INTO INICIATIVA_METAS VALUES (2, 2, '2.1');
INSERT INTO INICIATIVA_METAS VALUES (3, 3, '3.1');
INSERT INTO INICIATIVA_METAS VALUES (4, 4, '4.1');
INSERT INTO INICIATIVA_METAS VALUES (4, 5, '5.1');