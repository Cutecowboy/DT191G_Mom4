# Moment 4 - Webbtjänster

API skapat genom .NET inbyggda API system. 

## Music API 

Innehåller information om:
- Artist
- Låttitel
- längd
- categori id

### GET

Get metoden är indelat i två delar:
- /api/Music som returnerar alla låtar
- /api/Music/{id} som returnerar vald id

### POST

POST skapar en ny låt som kräver följande inmatning
- artist {string, required}
- title {string, required}
- length {int, required}
- catId {int}

### PUT

Put reviderar en låt och kräver följande inmatning med url /api/Music/{id}
- artist {string, required}
- title {string, required}
- length {int, required}
- catId {int}

### DELETE

DELETE tar bort en låt givet inmatad id med url /api/Music/{id}
