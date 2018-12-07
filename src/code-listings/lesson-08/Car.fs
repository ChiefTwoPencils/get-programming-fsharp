module Car

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