Feature: Review

User using the review feature to rate an item on the shopping site

@tag1
Scenario: User can Write a review of a clothing item
	Given I am signed into my account
	When I proceed to select a clothing item
	And I select Review option on the item display page
	And I submit a review via the review form
	Then I recevie a success message stating I have submited a review
