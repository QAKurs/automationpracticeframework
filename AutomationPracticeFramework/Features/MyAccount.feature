Feature: MyAccount
	Simple calculator for adding two numbers

Background: 
	Given user opens sign in page

@MyAccount
Scenario: User can log in
	And enters correct credentials
	When user submits the login form
	Then user will be logged in

@MyAccount
Scenario: User can create an account
	And initiates a flow for creating an account
	And user enters all required personal details
	When submits the sign up form
	Then user will be logged in
	And user's full name is displayed

Scenario: User can open wishlist
	Given user is logged in