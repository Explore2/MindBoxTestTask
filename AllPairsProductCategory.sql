SELECT Products.Title, Category.Title
FROM (Products LEFT JOIN ProductCategory ON Products.ID = ProductCategory.ProductID)
LEFT JOIN Category ON ProductCategory.CategoryID = Category.ID
ORDER BY Category.ID;
