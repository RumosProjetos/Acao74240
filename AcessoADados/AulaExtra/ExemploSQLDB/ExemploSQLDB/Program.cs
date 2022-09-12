using ExemploSQLDB;
using Microsoft.Azure.Cosmos;


var conexao = @"AccountEndpoint=https://cosmos-rumos-sql-ukw.documents.azure.com:443/;AccountKey=mG9bntpFrO2GlX6IETyPTJMuPethHUlaCJ4RwavFNP6xwBFQrAfemveYNN6ABzEjOVS295TNdPgVrzBOO3MCXg==;";
using CosmosClient client = new(conexao);

// Database reference with creation if it does not already exist
Database database = await client.CreateDatabaseIfNotExistsAsync(
    id: "sapataria"
);
Console.WriteLine($"New database:\t{database.Id}");


// Container reference with creation if it does not alredy exist
Container container = await database.CreateContainerIfNotExistsAsync(
    id: "products",
    partitionKeyPath: "/category",
    throughput: 400
);
Console.WriteLine($"New container:\t{container.Id}");



// Create new object and upsert (create or replace) to container
Product newItem = new(
    id: "68719518391",
    category: "gear-surf-surfboards",
    name: "Yamba Surfboard",
    quantity: 12,
    sale: false
);

Product createdItem = await container.UpsertItemAsync<Product>(
    item: newItem,
    partitionKey: new PartitionKey("gear-surf-surfboards")
);

Console.WriteLine($"Created item:\t{createdItem.id}\t[{createdItem.category}]");




var query = new QueryDefinition(
    query: "SELECT * FROM products p WHERE p.category = @key AND p.name = @name"
)
    .WithParameter("@key", "gear-surf-surfboards")
    .WithParameter("@name", "Yamba Surfboard");



using FeedIterator<Product> feed = container.GetItemQueryIterator<Product>(
    queryDefinition: query
);


while (feed.HasMoreResults)
{
    FeedResponse<Product> response = await feed.ReadNextAsync();
    foreach (Product item in response)
    {
        Console.WriteLine($"Found item:\t{item.name}");
    }
}