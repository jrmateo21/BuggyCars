Feature: PopularCarFeature
 As a user 
 I would like to  create  a comment and vote
 

@FirstRankCarVoteandComment
Scenario: Create a comment and vote 
	Given I logged into buggy cars portal successfully
	When  I navigate to popular page
	When  I navigate to first rank car then was able to  vote and comment
	Then  Vote  and comment should be  recorded 


@FirstRankCarVoteandCommentDataDriven
Scenario Outline: Create a comment and vote with given data
	Given I logged into buggy cars portal successfully
	When  I navigate to popular page
	When  I navigate to first rank car then was able to  vote and '<Comment>'
	Then  Voted  and '<Comment>' should be  recorded 

	Examples: 
	| Comment             |
	| Data Driven Testing |
	| Data Driven Testing2 |



	

@EndtoEndTestingRegression
Scenario Outline: Login user with given data and  able to vote and comment.
	Given I logged into buggy cars portal successfully with valid '<Username>' and '<Password>'
	When  I navigate to popular page
	When  I navigate to first rank car then was able to  vote and '<Comment>'
	Then  Voted  and '<Comment>' should be  recorded 

	Examples: 

	| Username   | Password        | Comment              |
	| Test_00003 | Test_00001_Pass | Data Driven Testing3 |
	| Test_00004 | Test_00001_Pass | Data Driven Testing3 |
	| Test_00008 | Test_00001_Pass | Data Driven Testing3 |
	




