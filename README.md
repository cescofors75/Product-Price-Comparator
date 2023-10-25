# Product Price Comparator

This tool allows users to search for products using their reference numbers and compare their prices across multiple stores. The primary objective is to highlight price differences, aiding users in making informed purchasing decisions.

## Features:

1. **Local Database Search:** Searches for product details within a local MySQL database.
2. **Barcode Lookup:** Fetches product prices from different stores using the BarcodeLookup API.
3. **Price Comparison:** 
   - Prices higher than the database are highlighted in green.
   - Prices lower than the database are highlighted in red.

## Usage:

- Start the application and you'll be presented with a user interface where you can input a product reference.
- Click on the "Search" button to initiate the search.
- The results will display the product details from the local database and enumerate the prices from various stores.

## Prerequisites:

- .NET Framework
- MySQL
- Newtonsoft.Json library (for JSON parsing)
- BarcodeLookup API key

## Setup:

1. Clone the repository.
2. Ensure you have the .NET Framework and MySQL installed on your system.
3. Update the `connectionString` in the `searchEan` method with your MySQL credentials.
4. Insert your BarcodeLookup API key in the `GetCodes` method where `api_key` is referenced.
5. Build and run the project.
6. **Note:** Ensure the required image (`fondo.jpg`) is present in the `.\images\` directory for the background. For security, avoid hardcoding the API key directly in your code. Consider utilizing environment variables or other secure techniques.

## Contributions:

Contributions are heartily welcomed! If you have suggestions or improvements, please open an issue or submit a pull request.


![image](https://user-images.githubusercontent.com/88708847/167812471-98f3be02-de61-46cc-87a5-a312eb40385c.png)


![image](https://user-images.githubusercontent.com/88708847/167812561-a6f641ec-5df7-41f6-b196-b559a44299ba.png)

