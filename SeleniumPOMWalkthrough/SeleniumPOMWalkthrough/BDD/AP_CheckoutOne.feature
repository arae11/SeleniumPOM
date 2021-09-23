Feature: AP_CheckoutOne
	In order to be able to buy items 
	As a registered user of the sauce demo website
	I want to be able to input my checkout information

@checkoutone @happy
Scenario: Valid checkout fields
	Given I am on the first checkout page
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I enter the following checkout information
	| FirstName | LastName | PostalCode |
	| Alex      | Rae      | SL5        |
	And I click the continue button
	Then I am taken to the checkout step two page

@checkoutone @sad
Scenario: No checkout fields completed
	Given I am on the first checkout page
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I enter the following checkout information
	| FirstName | LastName | PostalCode |
	|           |          |            |
	And I click the continue button
	Then I should see an alert containing the error message "Error: First Name is required"

@checkoutone @sad
Scenario: Only firstname field completed
	Given I am on the first checkout page
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I enter the following checkout information
	| FirstName | LastName | PostalCode |
	| Alex      |          |            |
	And I click the continue button
	Then I should see an alert containing the error message "Error: Last Name is required"

@checkoutone @sad
Scenario: Only name fields completed
	Given I am on the first checkout page
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I enter the following checkout information
	| FirstName | LastName | PostalCode |
	| Alex      | Rae      |            |
	And I click the continue button
	Then I should see an alert containing the error message "Error: Postal Code is required"

@checkoutone @sad
Scenario: Only postcode field completed
	Given I am on the first checkout page
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I enter the following checkout information
	| FirstName | LastName | PostalCode |
	|           |          | SL5        |
	And I click the continue button
	Then I should see an alert containing the error message "Error: First Name is required"

@checkoutone @sad
Scenario: Only lastname field completed
	Given I am on the first checkout page
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I enter the following checkout information
	| FirstName | LastName | PostalCode |
	|           | Rae      |            |
	And I click the continue button
	Then I should see an alert containing the error message "Error: First Name is required"

@checkoutone @sad
Scenario: Only postcode and firstname fields completed
	Given I am on the first checkout page
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I enter the following checkout information
	| FirstName | LastName | PostalCode |
	| Alex      |          | SL5        |
	And I click the continue button
	Then I should see an alert containing the error message "Error: Last Name is required"

@checkoutone @sad
Scenario: Only postcode and lastname fields completed
	Given I am on the first checkout page
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I enter the following checkout information
	| FirstName | LastName | PostalCode |
	|           | Rae      | SL5        |
	And I click the continue button
	Then I should see an alert containing the error message "Error: First Name is required"

@checkoutone
Scenario: Go back to cart
	Given I am on the first checkout page
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I click the cancel button
	Then I am taken to my cart
