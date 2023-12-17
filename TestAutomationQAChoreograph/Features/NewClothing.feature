Feature: NewClothing

New Clothing Section known as Whats New

@tag1
Scenario: User can view whats new in the shop
	Given I am logged into my account
	When I Select the Whats New option on my main menu
	And Im redirected to the Whats New Page
	And I Scroll down towards the bottom of the page
	Then I see New clothing available


Scenario: User can add a new clothing item to their wishlist
	Given I am logged into my account
	When I Select the Whats New option on my main menu
	And Im redirected to the Whats New Page
	And I proceed to Hoodies and Jackets under 'New In Mens'
	Then I can select an item I want to add to my wishlist
	