-- AVANT D'INSERER LES DONNEES PLATS, BOISSONS ET DECOUVERTES, CREEZ L'iINSERT CATEGORIES AVANT ! -- 
-- TABLE DISHES --

INSERT INTO Dishes ("Title", "Description", "Price", "CategoryId")
VALUES ("Carpaccio de bœuf", "Tranches fines de bœuf, vinaigrette au poivre noir", 10, 1);

INSERT INTO Dishes ("Title", "Description", "Price", "CategoryId")
VALUES ("Velouté de potiron", "Potiron et poivre de Sichuan", 8, 1);

INSERT INTO Dishes ("Title", "Description", "Price", "CategoryId")
VALUES ("Crevettes sautées", "Crevettes sautées, crème fraîche et poivre vert", 12, 1);

INSERT INTO Dishes ("Title", "Description", "Price", "CategoryId")
VALUES ("Salade de chèvre", "Salade, fromage de chèvre, et vinaigrette au poivre blanc", 9, 1);

INSERT INTO Dishes ("Title", "Description", "Price", "CategoryId")
VALUES ("Tartare de saumon", "Tartare de saumon et poivre de Sichuan", 14, 1);

INSERT INTO Dishes ("Title", "Description", "Price", "CategoryId")
VALUES ("Steak", "Steak de bœuf, sauce au poivre, accompagnement frite et salade", 18, 2);

INSERT INTO Dishes ("Title", "Description", "Price", "CategoryId")
VALUES ("Poulet rôti", "Cuisse de poulet rôti, sauce au poivre rouge, accompagnement salade et frite", 15, 2);

INSERT INTO Dishes ("Title", "Description", "Price", "CategoryId")
VALUES ("Pâtes aux fruits de mer", "Tagliatelles, moules, crevettes, calamars et sauce au poivre blanc", 20, 2);

INSERT INTO Dishes ("Title", "Description", "Price", "CategoryId")
VALUES ("Ragoût de légumes et lentilles aux herbes", "Légumes de saisons, lentilles, cumin, paprika, curcuma et sauce au poivre noir", 16, 2);

INSERT INTO Dishes ("Title", "Description", "Price", "CategoryId")
VALUES ("Filet de canard au miel", "Canard grillé, glaçage au miel et sauce au poivre rose et pommes de terre rôti au thym", 22, 2);

INSERT INTO Dishes ("Title", "Description", "Price", "CategoryId")
VALUES ("Tarte au chocolat", "Ganache chocolat noir, noisettes croquantes et poivre rose", 7, 3);

INSERT INTO Dishes ("Title", "Description", "Price", "CategoryId")
VALUES ("Glace Vanille/Caramel", "Glace crémeuse, poivre long et coulis au choix*", 6, 3);

INSERT INTO Dishes ("Title", "Description", "Price", "CategoryId")
VALUES ("Poires pochées", "Poire pochée au sirop, arôme poivre de Jamaïque et coulis au choix*", 9, 3);

INSERT INTO Dishes ("Title", "Description", "Price", "CategoryId")
VALUES ("Crème brûlée", "Crème arôme vanille brûlée et poivre noir", 8, 3);

INSERT INTO Dishes ("Title", "Description", "Price", "CategoryId")
VALUES ("Soufflé aux fruits", "Fruits de saison, sel, poivre vert et noix de muscade", 10, 3);

-- TABLE DRINKS --

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Eau plate", 2, 4);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Eau pétillante", 2.5, 4);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Soda", 3, 4);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Jus de fruit", 3.5, 4);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Sirop", 2.5, 4);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Cocktail poivré", 8, 5);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Margarita au poivre", 10, 5);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Gin & Poivre", 9, 5);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Old Fashioned poivré", 12, 5);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Spritz au poivre", 11, 5);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Bière blonde locale", 4.5,6);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("IPA Artisanale", 5, 6);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Pilsner", 4, 6);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Vin rouge de la région", 6, 6);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Vin blanc de la région", 5, 6);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Whisky", 7, 7);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Rhum ambré", 7.5, 7);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Tequila", 8, 7);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Cognac", 8, 7);

INSERT INTO Drinks ("Name", "Price", "CategoryId") 
VALUES ("Chartreuse", 10, 7);

-- TABLE CATEGORIES --

INSERT INTO Categories ("Title") 
VALUES ("Entrée");

INSERT INTO Categories ("Title") 
VALUES ("Plat");

INSERT INTO Categories ("Title") 
VALUES ("Dessert");

INSERT INTO Categories ("Title") 
VALUES ("Boissons sans alcool");

INSERT INTO Categories ("Title") 
VALUES ("Apéritifs");

INSERT INTO Categories ("Title") 
VALUES ("Bières et vins");

INSERT INTO Categories ("Title") 
VALUES ("Alcool forts, spiritueux, digestifs");

INSERT INTO Categories ("Title") 
VALUES ("Entrées");

INSERT INTO Categories ("Title") 
VALUES ("Plats");

INSERT INTO Categories ("Title") 
VALUES ("Desserts");

-- TABLE EMPLOYEES --

INSERT INTO Employees ("FirstName", "LastName", "PathImg", "Role", "HireDate") 
VALUES('Marc', 'Dubois', NULL, 'Propriétaire', '1992-04-17'),
('Alice', 'Smith', NULL, 'Gérante', '1999-02-15'),
('Emma', 'Johnson', NULL, 'Commis cuisine', '2019-03-10'),
('Michael', 'Williams', NULL, 'Chef cuisinier', '2012-04-20'),
('Sophie', 'Brown', NULL, 'Comptable', '2020-05-05'),
('David', 'Lee', NULL, 'Serveur', '2022-06-30'),
('Laura', 'Garcia', NULL, 'Plongeur', '2021-07-15'),
('Alex', 'Johnson', NULL, 'Barman', '2004-09-27'),
('Sophie', 'Martin', NULL, 'Serveuse', '2019-06-23'),
('Thomas', 'Leroy', NULL, 'Responsable de communication', '2023-09-27');

-- TABLE DISCOVERS --

INSERT INTO Discovers ("Name", "Description", "Price", "CategoryId") 
VALUES ('Vole-au-vent', 'Vole-au-vent de volaille jaune, oignons caramélisés, carottes, émulsion de poivre vert', 7.50, 8);

INSERT INTO Discovers ("Name", "Description", "Price", "CategoryId") 
VALUES ('Saumon gravlax', 'Saumon gravlax, tuile de parmesan au poivre, mousse de poivre blanc et aneth', 8.50, 8);

INSERT INTO Discovers ("Name", "Description", "Price", "CategoryId") 
VALUES ('Turbot braisé', 'Turbot braisé, fumet de poisson au poivre, tagliatelles, chips de carottes', 8.50, 9);

INSERT INTO Discovers ("Name", "Description", "Price", "CategoryId") 
VALUES ('Carré d''agneau', 'Carré d''agneau, pommes dauphines, fenouil rôti, émulsion de poivre, jus serré d''agneau', 9, 9);

INSERT INTO Discovers ("Name", "Description", "Price", "CategoryId") 
VALUES ('Dôme chocolat', 'Dôme chocolat noir, mousse de fruits rouges, sirop au poivre de jamaïque, pralin pistache et poivre vert', 6.50, 10);

INSERT INTO Discovers ("Name", "Description", "Price", "CategoryId") 
VALUES ('Déclinaison de citron', 'Dacquoise coco et citron vert, gel yuzu et poivre de jamaïque, citron caviar et émulsion de poivre vert', 7, 10);

-- TABLE REVIEWS --

INSERT INTO Reviews ("Name", "Rating", "Commentaire") 
VALUES ("Daniel", "5", "J'ai récemment découvert ce restaurant et j'ai été agréablement surpris par la variété de plats au poivre qu'ils proposent.
Des entrées aux desserts, chaque bouchée était une explosion de saveurs.
Ambiance parfaite pour une soirée délicieusement épicée.");

INSERT INTO Reviews ("Name", "Rating", "Commentaire") 
VALUES ("Richard", "5", "En tant qu'amateur de plats épicés, j'ai été comblé par ce restaurant spécialisé dans le poivre.
Les chefs maîtrisent l'art d""équilibrer la chaleur du poivre avec d""autres saveurs.
Le service était également impeccable.");

INSERT INTO Reviews ("Name", "Rating", "Commentaire") 
VALUES ("Isabelle", "5", "Ce restaurant m'a transportée dans un voyage gustatif unique.
Chaque plat était une exploration de différentes variétés de poivre, apportant une profondeur de saveur que je n'avais jamais connue auparavant.
Je recommande vivement cet endroit à tous les amateurs de cuisine audacieuse.");

INSERT INTO Reviews ("Name", "Rating", "Commentaire") 
VALUES ("Julia", "5", "J'ai eu le plaisir de choisir le menu découverte de ce restaurant, et je suis encore sous le charme de cette expérience culinaire.
Le menu était parfaitement équilibré, avec des créations originales mettant en valeur chaque ingrédient.
Le chef a clairement un talent exceptionnel pour harmoniser les goûts et les textures!");

-- Ajouter une interface admin par model --

dotnet aspnet-codegenerator controller -name AdminBookController -m Book -dc restaurant_dotnet.Data.RestaurantContext --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite