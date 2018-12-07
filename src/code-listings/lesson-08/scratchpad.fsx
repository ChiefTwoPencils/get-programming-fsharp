open System

/// Gets the distance to a given destination 
let getDistance (destination) =
    let d = destination
    if d = "Gas" then 10    
    elif d = "Home" || d = "Stadium" then 25 
    elif d = "Office" then 50
    else failwith "Unknown destination!"

/// Gets the new petrol state by distance
let calculateRemainingPetrol(currentPetrol, distance) =
    if currentPetrol >= distance then currentPetrol - distance
    else failwith "Oops! You've run out of petrol"

let driveTo(petrol, destination) =
    let remaining = calculateRemainingPetrol(petrol, getDistance(destination))
    if destination = "Gas" then remaining + 50
    else remaining

// Couple of quick tests
getDistance("Home") = 25
getDistance("Stadium") = 25

calculateRemainingPetrol(5,2) = 3
calculateRemainingPetrol(1,1) = 0
calculateRemainingPetrol(0,4) = 5

let a = driveTo(100, "Office")
let b = driveTo(a, "Stadium")
let c = driveTo(b, "Gas")
let answer = driveTo(c, "Home")