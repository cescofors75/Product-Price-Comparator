Tools3 
Comparative price 

Product Price Comparator
This project allows users to search for products using their reference numbers and compare their prices across different stores. The primary goal is to highlight price differences, helping users make informed decisions.

Features:
Local Database Search: Searches for product details in a local MySQL database.
Barcode Lookup: Fetches product prices from different stores using the BarcodeLookup API.
Price Comparison: Highlights price differences in green (for prices higher than the database) and red (for prices lower than the database).
Usage:
Start the application and you'll be presented with a UI where you can enter a product reference.
Click on the "Search" button to begin the search.
The results will show the product details from the local database and list the prices from various stores.
Prerequisites:
.NET Framework
MySQL
Newtonsoft.Json library for JSON parsing
A BarcodeLookup API key
Setup:
Clone the repository.
Ensure you have the .NET Framework and MySQL set up on your machine.
Update the connectionString in the searchEan method with your MySQL credentials.
Insert your BarcodeLookup API key in the GetCodes method where api_key is defined.
Build and run the project.
Note:
Ensure you have the required image (fondo.jpg) in the .\images\ directory for the background.
Make sure you handle the API key securely. Avoid hardcoding it directly into your code. Consider using environment variables or other secure methods.
Contributions:
Contributions are welcome! Please open an issue or submit a pull request if you have improvements or fixes.

![image](https://user-images.githubusercontent.com/88708847/167812471-98f3be02-de61-46cc-87a5-a312eb40385c.png)


![image](https://user-images.githubusercontent.com/88708847/167812561-a6f641ec-5df7-41f6-b196-b559a44299ba.png)

