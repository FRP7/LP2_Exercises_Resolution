using System.Collections;
using System.Collections.Generic;

public class BasketballTeam : IEnumerable<string>
{
    public string Guard { get; set; }
    public string ShootingGuard { get; set; }
    public string SmallForward { get; set; }
    public string PowerForward { get; set; }
    public string Center { get; set; }

    public IEnumerator<string> GetEnumerator() {
        yield return Guard;
        yield return ShootingGuard;
        yield return SmallForward;
        yield return PowerForward;
        yield return Center;
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}