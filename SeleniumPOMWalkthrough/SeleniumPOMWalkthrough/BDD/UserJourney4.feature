Feature: UserJourney4
	As a registered user of the sauce demo website
	I want to be able to purchase sort items by price and purchase the cheapest item
	So that I can save money on sauce labs merchandise

@userjourney
Scenario: Sort all items by price and purchase the cheapest item
	Given that I have logged in
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I sort the items by price (low to high)
	And I click add to cart on the cheapest item
	And I click the shopping cart button
	And I click checkout
	And I enter the following checkout information
	| FirstName | LastName | PostalCode |
	| Alex      | Rae      | SL5        |
	And I click the continue button
	And I click finish
	Then I should be taken to the checkout completed page