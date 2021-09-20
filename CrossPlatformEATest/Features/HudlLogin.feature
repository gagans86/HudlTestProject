Feature: HudlLogin
	Verify the login user


@smoke @positive
Scenario: Verify the login user
	Given Navigate to hudl login
	And  Enter username
	When Enter password
	Then verify the user is loggedin