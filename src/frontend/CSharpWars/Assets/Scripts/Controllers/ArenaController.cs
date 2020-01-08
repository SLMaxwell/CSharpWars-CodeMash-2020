using Assets.Scripts.Model;
using Assets.Scripts.Networking;
using UnityEngine;


namespace Assets.Scripts.Controllers
{
    public class ArenaController : MonoBehaviour
    {
        private Arena _arena;

        public void Start()
        {
            _arena = ApiClient.GetArena();
            var floor = GameObject.Find("Floor");
            floor.transform.localScale = new Vector3(x:_arena.Width, y:0.1f, z:_arena.Height);
            floor.GetComponent<Renderer>().material.mainTextureScale = new Vector2(x:_arena.Width, y:_arena.Height);
        }
    }
}