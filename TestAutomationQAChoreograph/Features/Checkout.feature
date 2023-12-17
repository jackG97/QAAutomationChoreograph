Feature: Checkout

Checkout feature for buying clothes

@tag1
Scenario: User can buy clothes
	Given I am logged into my shopping account
	When I want select an item to purchase from Mens Section
	And I add it to my shopping cart
	And I enter in my shipping and payment information
	Then I should receive a shopping success message after buying it


Scenario: User remove Item from Basket
	Given I am logged into my shopping account
	When I want select an item to purchase from Mens Section
	And I add it to my shopping cart
	And I Select the bin icon to delete it
	Then It should be removed from my basket