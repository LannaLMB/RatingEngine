# Simplified Rating Engine and Quote Generator 
##### This API takes in a Revenue, State, and Business.
##### It then calculates and generates a quote.


### To Test This App:
- ##### Clone the repository
- ##### Run the application
- ##### In the Swagger interface click on "Try it out"
- ##### In the JSON request body fill in the parameters with the below values so it looks as follows:
```
{
    revenue: 6000000,
    state: 'TX',
    business: 'Plumber'
}
```
- ##### Click "Execute"
- ##### You should see the below response body returned:
```
{
    premium: 11316
}
```

### Enhancements
- ##### Add logging
- ##### Add unit tests
- ##### Add Dependency Injection for scalability
- ##### Update datatypes where necessary to reflect appropriate data being held
- ##### Update names for clarification and scalability
- ##### Create separate class to hold all of the eligible states
- ##### Ability to test with Postman
- ##### Potential database depending on use case
- ##### Exception and error handling
- ##### Asynchronous methods