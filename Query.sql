SELECT Products.name, Category.name
FROM Products LEFT JOIN Catefory ON Products.id=Category.productId
ORDER BY Products.name;