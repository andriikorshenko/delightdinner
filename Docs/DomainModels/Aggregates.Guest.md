# Domain Model

## GuestAggregate

```csahrp
	// TODO: Add methods
```

```json
{
	"id": { "value": "0000000-000-000-00000000000" },
	"firstName": "John",
	"lastName": "Doe",
	"profileImage": "https://www.example.com/image.jpg",
	"averageRating": 4.5,
	"userId": { "value": "0000000-000-000-00000000000" },
	"upcomigDinner": [
		{ "value": "0000000-000-000-00000000000" }
	],
	"pastDinnerIds": [
        { "value": "00000000-0000-0000-0000-000000000000" }
    ],
    "pendingDinnerIds": [
        { "value": "00000000-0000-0000-0000-000000000000" }
    ],
	 "billIds": [
        { "value": "00000000-0000-0000-0000-000000000000" }
    ],
    "menuReviewIds": [
        { "value": "00000000-0000-0000-0000-000000000000" }
    ],
    "ratings": [
        {
            "id": { "value": "00000000-0000-0000-0000-000000000000" },
            "hostId": { "value": "00000000-0000-0000-0000-000000000000" },
            "dinnerId": { "value": "00000000-0000-0000-0000-000000000000" },
            "rating": 4,
            "createdDateTime": "2020-01-01T00:00:00.0000000Z",
            "updatedDateTime": "2020-01-01T00:00:00.0000000Z"
        }
    ],
    "createdDateTime": "2020-01-01T00:00:00.0000000Z",
    "updatedDateTime": "2020-01-01T00:00:00.0000000Z"
}
```