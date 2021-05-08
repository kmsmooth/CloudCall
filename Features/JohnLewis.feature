Feature: JohnLewis
	As a Jobseeker with CloudCall
    I want to create automation from scratch
    So they know that i am competent for the role


@JohnLewis
Scenario: Create a user journey test from scratch in an automation framework of your choice for
the John Lewis website (https://www.johnlewis.com/).

	Given Given User navigates to Johnlewis website
	And  User accepts the cookie banner
	And  User browse for a product
	And  User select multiple quantities of the product
	And  User add selected product to the basket
	And  User delete the product quantities from basket
	When User clear cookies
	Then Cookies cleared should be displayed