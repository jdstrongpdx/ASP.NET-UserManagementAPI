using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private static readonly List<User> Users = new List<User>();

    [HttpGet]
    public IActionResult GetAllUsers() => Ok(Users);

    [HttpGet("{id}")]
    public IActionResult GetUserById(int id)
    {
        var user = Users.FirstOrDefault(u => u.Id == id);
        if (user == null) return NotFound(new { error = "User not found" });
        return Ok(user);
    }

    [HttpPost]
    public IActionResult AddUser([FromBody] User newUser)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        newUser.Id = Users.Count > 0 ? Users.Max(u => u.Id) + 1 : 1;
        Users.Add(newUser);
        return CreatedAtAction(nameof(GetUserById), new { id = newUser.Id }, newUser);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateUser(int id, [FromBody] User updatedUser)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState); // Validate the model first

        var user = Users.FirstOrDefault(u => u.Id == id);
        if (user == null) return NotFound(new { error = "User not found" });

        user.Name = updatedUser.Name;
        user.Email = updatedUser.Email;

        // Return 200 OK with the updated user data
        return Ok(user);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteUser(int id)
    {
        var user = Users.FirstOrDefault(u => u.Id == id);
        if (user == null) return NotFound(new { error = "User not found" });

        Users.Remove(user);
        return NoContent();
    }
}