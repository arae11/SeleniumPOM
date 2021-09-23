Feature: UserJourney1
	As a registered user of the sauce demo website
	I want to be able to purchase a sauce labs backpack
	So that I can be bullied at school

@userjourney
Scenario: Purchase backpack user journey
	Given that I have logged in
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I click add to cart on the backpack
	And I click the shopping cart button
	And I click checkout
	And I enter the following checkout information
	| FirstName | LastName | PostalCode |
	| Alex      | Rae      | SL5        |
	And I click the continue button
	And I click finish
	Then I should be taken to the checkout completed page