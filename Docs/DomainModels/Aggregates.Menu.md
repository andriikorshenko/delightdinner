# DomainModels

## MenuAggregate

```csharp
class Menu
{
	Menu Create();
	void AddDinner(Dinner dinner);
	void RemoveDinner(Dinner dinner);
	void UpdateSection(MenuSection section);
}
```

```json
{
	"id": { "value": "0000000-000-000-00000000000" },
	"name": "Yammy menu",
	"description": "A menu with yammy food",
	"averageRating": {
        "value": 4.5,
        "numRating": 1,
    },
	"sections": [
		"id": { "value": "0000000-000-000-00000000000" },
		"name": "Appetizers",
		"description": "Starters",
		"items": [
			{
				"id": { "value": "0000000-000-000-00000000000" },
				"name": "Fried Pickles",
				"description": "Deep fried pickles"
			}
		]
	],
	"hostId": { "value": "0000000-000-000-00000000000" },
	"dinnerIds": [
		{ "value": "0000000-000-000-00000000000" }
	],
	"menuReviewIds": [
		{ "value": "0000000-000-000-00000000000" }
	],
	"createdDateTime": "2023-01-01T00:00:00.0000000Z",
	"updatedDateTime": "2023-01-01T00:00:00.0000000Z",
}
```