SELECT product.product_name, sale.year, sale.price
FROM Sales sale
JOIN Product product
ON  sale.product_id = product.product_id