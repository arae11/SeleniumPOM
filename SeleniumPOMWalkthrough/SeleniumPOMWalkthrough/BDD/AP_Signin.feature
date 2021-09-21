Feature: AP_Signin
	In order to be able to buy items 
	As a registered user of the sauce demo website
	I want to be able to sign in to my account

@login
Scenario: Valid login
	Given I am on the homepage
	And I enter the following credentials
	| Username      | Password     |
	| standard_user | secret_sauce |
	When I enter these credentials
	And I click the login button
	Then I should be logged in and sent to the inventory page

@login
Scenario: No username or password
	Given I am on the homepage
	And I enter the following credentials
	| Username | Password |
	|          |    	  |
	When I enter these credentials
	And I click the login button
	Then I should see an alert containing the error message "Epic sadface: Username is required"

@login
Scenario: Valid username but no password
	Given I am on the homepage
	And I enter the following credentials
	| Username      | Password     |
	| standard_user |			   |
	When I enter these credentials
	And I click the login button
	Then I should see an alert containing the error message "Epic sadface: Password is required"

@login
Scenario: Valid username but invalid password
	Given I am on the homepage
	And I enter the following credentials
	| Username      | Password     |
	| standard_user | Hello World  |
	When I enter these credentials
	And I click the login button
	Then I should see an alert containing the error message "Epic sadface: Username and password do not match any user in this service"

@login
Scenario: Invalid username and password
	Given I am on the homepage
	And I enter the following credentials
	| Username | Password |
	| Hello	   | World	  |
	When I enter these credentials
	And I click the login button
	Then I should see an alert containing the error message "Epic sadface: Username and password do not match any user in this service"