USE user_authentication_db;

CREATE TABLE product_tbl
(
	productID INT PRIMARY KEY UNIQUE NOT NULL AUTO_INCREMENT,
    productName VARCHAR(255) NOT NULL,
    productPrice DECIMAL NOT NULL
);

CREATE TABLE stocks_tbl
(
	productID INT NOT NULL,
    quantity INT NOT NULL,
    
    FOREIGN KEY (productID) REFERENCES product_tbl(productID)
);

DELIMITER //
CREATE PROCEDURE AddProduct(IN name VARCHAR(255), price DECIMAL)
BEGIN
	INSERT INTO product_tbl (productName, productPrice)
    VALUES (name, price);
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE AddStock(IN productID INT, IN quantity INT)
BEGIN
	INSERT INTO stocks_tbl (productID, quantity)
    VALUES (productID, quantity);
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE ReadStocks()
BEGIN
	SELECT P.productID, p.productName, P.productPrice, S.quantity
    FROM product_tbl AS P
    INNER JOIN stocks_tbl AS S;
END //
DELIMITER ;

/*
CALL AddProduct("Hamburger", 20);
CALL AddStock(8, 25);
*/