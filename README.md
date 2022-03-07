# FunBookAndVideoOrderProcessor

FunBooksAndVideos is an e-commerce shop where customers can view books and watch online videos. Users can have memberships for the book
club, the video club or for both clubs (premium).

# Description 

- Generate Purchase order and process on it. 
- Purchase order contains ID, Customer Infoemation , Total Price and list of items. 
- Items in purchase order can be Membership or physical or non-physical item.
- If membership is there then activate membership of customer imiidiately. (Type of membership can be Book, video or premium)
- Other then membership other item can be Physical or Non-physical
- If item falls under physical category then create Shipping slip 

#  Required Software

.net 5

# How to Install 

- Download code using : "https://github.com/Priyal1989/FunBookAndVideoOrderProcessor.git"	
- Extract the Zip file and open project in Visual studio using "FunBooksAndVideos_Processor.sln" file

# Requirement

- Implement an Object Oriented model of the system
- Design a flexible purchase order processor
- Implement the above business rules

# Implementation 

- Each business rule is implemented in seperate file 
- Once order is created, system identify the applicable rules and its sequence using Rule Generator
- Rule sequnce is decide by Enum. We can make it DB driven. 
- Based on this RuleGenerator List system will execute every rule in sequence using Rule Executor

# Notes

- There is no UI or DataLayer/Repository Implemented for this.
- This application contains only business layer and model. 
- Code contains flexible purchase order processor
- Whenever any business rule will be added you just need to change RuleGenerator and RuleExceutor only. 
- We assume Book as a physical Item and video as nonphical item. 
